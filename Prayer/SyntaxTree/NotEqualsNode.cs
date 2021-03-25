public class NotEqualsNode : SyntaxNode {
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public NotEqualsNode(SyntaxNode l, SyntaxNode r) {
        this.l = l;
        this.r = r;
    }
}