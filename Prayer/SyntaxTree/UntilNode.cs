public class UntilNode : SyntaxNode {
    public SyntaxNode i {get;}
    public BlockNode body {get;}
    public UntilNode(SyntaxNode i,BlockNode body) {
        this.i = i;
        this.body = body;
    }
}