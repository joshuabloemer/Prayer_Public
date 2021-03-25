class DivisionNode : SyntaxNode{
    public SyntaxNode l {get;}
    public SyntaxNode r {get;}
    public DivisionNode(SyntaxNode l, SyntaxNode r){
        this.l = l;
        this.r = r;
    }

}