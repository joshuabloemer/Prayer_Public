public class GreaterThanNode : SyntaxNode {
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public GreaterThanNode(SyntaxNode l, SyntaxNode r) {
        this.l = l;
        this.r =r;
    }
}