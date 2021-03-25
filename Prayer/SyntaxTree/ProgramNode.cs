public class ProgramNode : SyntaxNode {
    public string filename {get;}
    public BlockNode body {get;}
    public ProgramNode (string filename, BlockNode body) {
        this.filename = filename;
        this.body = body;
    }
}