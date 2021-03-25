public class AssignNode : SyntaxNode {
    public VariableNode v {get;}
    public SyntaxNode e {get;}
    public AssignNode(VariableNode v, SyntaxNode e) {
        this.v = v;
        this.e = e;
    }

}