public class DecrementNode : SyntaxNode {
    public VariableNode l { get; }
    public DecrementNode(VariableNode l){
        this.l = l;
    }

}