public class Utils {
    public static T Max<T>(params T[] args)
    where T: System.IComparable<T>{
        if (args.Length == 0) {
            throw new System.Exception();
        }

        T result = args[0];

        foreach (T t in args) {
            if (t.CompareTo(result) > 0) {
                result = t;
            }
        }

        return result;
    }
}
