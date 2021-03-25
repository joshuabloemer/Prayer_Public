public class GreaterOrEqualNode : SyntaxNode {
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public GreaterOrEqualNode(SyntaxNode l,SyntaxNode r) {
        this.l = l;
        this.r = r;
    }
}