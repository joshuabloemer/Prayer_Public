public class IncrementNode : SyntaxNode {
    public VariableNode l { get; }
    public IncrementNode(VariableNode l){
        this.l = l;
    }

}
