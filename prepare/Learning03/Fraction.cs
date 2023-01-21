public class Fraction{
    private int _top;
    private int _bottom;
    private string first_result;
    private string second_result;
    private string third_result;

    public void SetFraction1(){
        _top = 1;
        _bottom = 1;
        first_result = ($"{_top}/{_bottom}");
    }

    public void SetFraction2(int top){
        _top = top;
        _bottom = 1;
        second_result = ($"{_top}/{_bottom}");
    }

    public void SetFraction3(int top , int bottom){
        _top = top;
        _bottom = bottom;
        third_result = ($"{_top}/{_bottom}");
    }

    public string DisplayFraction1(){
        return first_result;
    }

    public string DisplayFraction2(){
        return second_result;
    }

    public string DisplayFraction3(){
        return third_result;
    }


}