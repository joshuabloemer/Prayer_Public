using System;
public class BooleanNode : SyntaxNode {
    public bool Value {get;}
    public BooleanNode(string b) {
        if (b == "Thou shalt") {
            this.Value = true;
        }
        else if (b == "Thou shalt not") {
            this.Value = false;
        }
        else {
            throw(new Exception("Expected Thou shalt/Thou shalt not"));
        }
    }
    public override string ToString()
    {
        return ($"boolean:{Value}");
    }

}