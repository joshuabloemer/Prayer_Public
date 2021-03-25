using System;
using System.Collections.Generic;

namespace Prayer {
    class Evaluator {
        private Dictionary<string, object> variables = new Dictionary<string, object>();

        public object run(SyntaxNode node, string filename) {
            if (node is ProgramNode) {
                return ProgramNode((ProgramNode)node,filename);
            }
            throw(new Exception("Program must start with \"In the beginning God created filename\""));
        }



        public object Evaluate(SyntaxNode node) {
            switch(node) {
                case NumberNode n: return n.Value;
                case StringNode s: return s.s;
                case BooleanNode b: return b.Value;
                case OutputNode o: return Output(o);
                case BlockNode b: return BlockNode(b);
                case AdditionNode a: return AdditionNode(a);
                case SubtractionNode s: return SubtractionNode(s);
                case IncrementNode i: return IncrementNode(i);
                case DecrementNode d: return DecrementNode(d);
                case EqualsNode e: return EqualsNode(e);
                case NotEqualsNode ne: return NotEqualsNode(ne);
                case GreaterThanNode gt: return GreaterThanNode(gt);
                case LessThanNode lt: return LessThanNode(lt);
                case GreaterOrEqualNode ge: return GreaterOrEqualNode(ge);
                case LessOrEqualNode le: return LessOrEqualNode(le);
                case AssignNode n: return AssignNode(n);
                case LookupNode lu: return LookupNode(lu);
                case InitializeNode i: return InitializeNode(i);
                case IfStatementNode i: return IfStatementNode(i);
                case IfElseStatementNode ie: return IfElseStatementNode(ie);
                case UntilNode un: return UntilNode(un);
                case DivisionNode dn: return DivisionNode(dn);
                case MultiplicationNode mn: return MultiplicationNode(mn);
                case NotNode nn: return NotNode(nn);
                
                
            }
            throw(new Exception($"Unknown node type {node.GetType()}"));
        }

        private object ProgramNode(ProgramNode p,string filename) {
            if (p.filename == filename.Split('.')[0]) {
                return Evaluate(p.body);
            }
            throw(new Exception("Program must start with \"In the beginning God created filename\""));
        }
        private object NotNode(NotNode nn)
        {
            var l = Evaluate(nn.l);
            return ! (bool)l;
        }

        private object MultiplicationNode(MultiplicationNode mn) {
            var l = Evaluate(mn.l);
            var r = Evaluate(mn.r);
            if (l is decimal && r is decimal){
                return (decimal)l * (decimal)r;
            }
            throw(new Exception($"Can't multiply {l.GetType()} and {r.GetType()}"));
        }
        private object DivisionNode(DivisionNode dn) {
            var l = Evaluate(dn.l);
            var r = Evaluate(dn.r);
            if (l is decimal && r is decimal){
                return (decimal)l / (decimal)r;
            }
            throw(new Exception($"Can't divide {l.GetType()} and {r.GetType()}"));
        }

        private object UntilNode(UntilNode un) {
            object result = null;
            while (!((bool)Evaluate(un.i))){
                result = Evaluate(un.body);
            }
            return result;
        }

        private object IfElseStatementNode(IfElseStatementNode ie) {
            if((bool)Evaluate(ie.i)) {
                return Evaluate(ie.truebody);
            }
            return Evaluate(ie.falsebody);
        }

        private object IfStatementNode(IfStatementNode i) {
            if((bool)Evaluate(i.i)) {
                return Evaluate(i.truebody);
            }
            return false;
        }

        private object InitializeNode(InitializeNode i) {
            var name = i.v.Name;
            var value = (decimal)0;
            variables[name] = value;
            return true;
        }

        private object LookupNode(LookupNode lu) {
            var name = lu.v.Name;
            object output;
            if(variables.TryGetValue(name, out output)){
                return output;
            }
            else{
                throw(new Exception("Undefined Variable"));
            }
        }

        private object AssignNode(AssignNode n) {
            var name = n.v.Name;
            var value = Evaluate(n.e);
            if (variables.ContainsKey(name) || name == "the name of the Lord") {
                variables[name] = value;
                return true;
            }
            return false;
            
        }
        private object LessOrEqualNode(LessOrEqualNode le)
        {
            var l = Evaluate(le.l);
            var r = Evaluate(le.r);
            return (decimal)l <= (decimal)r;
        }
        private object GreaterOrEqualNode(GreaterOrEqualNode ge)
        {
            var l = Evaluate(ge.l);
            var r = Evaluate(ge.r);
            return (decimal)l <= (decimal)r;
        }
        private object LessThanNode(LessThanNode lt)
        {
            var l = Evaluate(lt.l);
            var r = Evaluate(lt.r);
            return (decimal)l < (decimal)r;
        }
        private object GreaterThanNode(GreaterThanNode gt)
        {
            var l = Evaluate(gt.l);
            var r = Evaluate(gt.r);
            return (decimal)l > (decimal)r;
        }
        private object NotEqualsNode(NotEqualsNode ne) {
            var l = Evaluate(ne.l);
            var r = Evaluate(ne.r);
            return (decimal)l != (decimal)r;
        }
        private object EqualsNode(EqualsNode e) {
            var l = Evaluate(e.l);
            var r = Evaluate(e.r);
            return (decimal)l == (decimal)r;
        }
        private object DecrementNode(DecrementNode d) {
            var name = d.l.Name;
            object output;
            if(variables.TryGetValue(name, out output)){
                if (output is decimal) {
                    variables[name] = ((decimal)output)+1;
                    return ((decimal)output)+1;
                    }
                else {
                    throw(new Exception($"Can't decrement {output.GetType()}"));
                }
            }
            else{
                throw(new Exception("Undefined Variable"));
            }
        }
        private object IncrementNode(IncrementNode i) {
            var name = i.l.Name;
            object output;
            if(variables.TryGetValue(name, out output)){
                if (output is decimal) {
                    variables[name] = ((decimal)output)+1;
                    return ((decimal)output)+1;
                    }
                else {
                    throw(new Exception($"Can't decrement {output.GetType()}"));
                }
            }
            else{
                throw(new Exception("Undefined Variable"));
            }
        }
        private object SubtractionNode(SubtractionNode s)
        {
            var l = Evaluate(s.l);
            var r = Evaluate(s.r);
            if (l is decimal && r is decimal){
                return (decimal)l - (decimal)r;
            }
            throw(new Exception($"Can't subtract {l.GetType()} and {r.GetType()}"));
        }
        private object AdditionNode(AdditionNode a) {
            var l = Evaluate(a.l);
            var r = Evaluate(a.r);
            if (l is decimal && r is decimal){
                return (decimal)l + (decimal)r;
            }
            throw(new Exception($"Can't add {l.GetType()} and {r.GetType()}"));
            
        }
        private object BlockNode(BlockNode b) {
            object result = null;
            foreach(var statement in b.Statements) {
                result = Evaluate(statement);
            }
            return result;
        }
        private object Output(OutputNode o) {
            object output;
            if(variables.TryGetValue("the name of the Lord", out output)){
                Console.WriteLine(output);
                return true;
            }
            else{
                throw(new Exception("Undefined output variable"));
                }
        }
    }
}