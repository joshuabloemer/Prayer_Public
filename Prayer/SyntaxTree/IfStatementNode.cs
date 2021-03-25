public class IfStatementNode : SyntaxNode{
    public SyntaxNode i {get;}
    public BlockNode truebody {get;}
    public IfStatementNode(SyntaxNode i, BlockNode truebody) {
        this.i = i;
        this.truebody = truebody;

    }
    
}