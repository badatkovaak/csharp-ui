using System.Collections.Generic;


public class Monom {
    double coefficient;
    List<int> powers;

    public Monom(double c, List<int> p){
        this.coefficient = c;
        this.powers = p;
    }

    public static Monom operator *(Monom A, Monom B) {
        List<int> p = new List<int>();
        int max_len = Utils.Max(A.powers.Count, B.powers.Count);

        for(int i = 0; i < max_len; i++) {
            int a = 0;

            if (A.powers.Count > i)
                a += A.powers[i];
            if (B.powers.Count > i)
                a += B.powers[i];

            p.Add(a);

        }

        return new Monom(A.coefficient * B.coefficient, p);
    }

    private void cleanup() {
        for(int i = 0; i < this.powers.Count; i++){
            if (this.powers[i] == 0)
                this.powers.RemoveAt(i);
        }
    }

    public override string ToString(){
        string result = "";

        if (this.coefficient != 1.0)
            result += this.coefficient.ToString();

        if(this.powers.Count == 1){
            if (this.powers[0] != 0)
                result += $"x^{this.powers[0]}";

            return result;
        }

        for(int i = 0; i < this.powers.Count; i++) {
            if (this.powers[i] != 0){
                if(result.Length != 0)
                    result += "*";

                result += $"x{i + 1}^{this.powers[i]}";
            }
        }

        if (result.Length == 0)
            result += "1";

        return result;
    }

}

public class Polynomial {
    List<Monom> monoms;

    public Polynomial(List<Monom> m){
        this.monoms = m;
    }

    public override string ToString(){
        string result = "";

        for(int i = 0; i < this.monoms.Count; i++){
            if (i > 0 && i != this.monoms.Count - 1)
                result += " + ";
            result += this.monoms[i].ToString();
        }

        return result;
    }
}
