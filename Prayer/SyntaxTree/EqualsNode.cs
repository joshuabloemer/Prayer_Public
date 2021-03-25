public class EqualsNode : SyntaxNode {
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public EqualsNode(SyntaxNode l, SyntaxNode r) {
        this.l = l;
        this.r = r;
    }
}