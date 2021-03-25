public class LessThanNode : SyntaxNode {
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public LessThanNode(SyntaxNode l, SyntaxNode r) {
        this.l = l;
        this.r =r;
    }
}