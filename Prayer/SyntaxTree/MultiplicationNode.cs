public class MultiplicationNode : SyntaxNode{
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public MultiplicationNode(SyntaxNode l, SyntaxNode r){
        this.l = l;
        this.r = r;
    }
} 