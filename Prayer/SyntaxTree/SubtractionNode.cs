public class SubtractionNode : SyntaxNode {
    public SyntaxNode l { get; }
    public SyntaxNode r { get; }
    public SubtractionNode(SyntaxNode l, SyntaxNode r) {
        this.l = l;
        this.r = r;
    }

}