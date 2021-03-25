public class IfElseStatementNode : SyntaxNode{
    public SyntaxNode i {get;}
    public BlockNode truebody {get;}
    public BlockNode falsebody{get;}
    public IfElseStatementNode(SyntaxNode i, BlockNode truebody, BlockNode falsebody) {
        this.i = i;
        this.truebody = truebody;
        this.falsebody = falsebody;

    }
    
}