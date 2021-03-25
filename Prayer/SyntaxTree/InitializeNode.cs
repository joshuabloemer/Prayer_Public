public class InitializeNode : SyntaxNode {
    public VariableNode v {get;}
    public InitializeNode (VariableNode v) {
        this.v = v;
    }
}