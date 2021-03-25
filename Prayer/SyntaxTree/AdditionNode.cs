public class AdditionNode : SyntaxNode {
    public SyntaxNode l { get; }
    public SyntaxNode r { get; }
    public AdditionNode(SyntaxNode l, SyntaxNode r) {
        this.l = l;
        this.r = r;
    }

}