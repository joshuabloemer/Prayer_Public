public class LessOrEqualNode : SyntaxNode {
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public LessOrEqualNode(SyntaxNode l,SyntaxNode r) {
        this.l = l;
        this.r = r;
    }
}