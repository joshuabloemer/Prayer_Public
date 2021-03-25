public class LookupNode : SyntaxNode {
    public VariableNode v {get;}
    public LookupNode (VariableNode v) {
        this.v = v;
    }
}