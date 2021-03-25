public class StringNode : SyntaxNode {
    public string s {get;}
    public StringNode(string s) {
        this.s = s;
    }
    public override string ToString() {
        return ($"String:{s}");
    }

}