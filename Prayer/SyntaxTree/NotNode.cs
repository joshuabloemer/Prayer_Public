public class NotNode : SyntaxNode {
    public SyntaxNode l {get;}
    public NotNode(SyntaxNode l) {
        this.l = l;
    }
}