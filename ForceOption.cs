using System.Linq;

namespace ForceOption
{
   public class CForceOption
   {
      private string[] _args { get; set; }
      private static string[] arr_strOptions = { "/f", "-f", "/force", "-force" };

      public CForceOption(string[] args) { _args = args; }

      public bool isForced { get { return IsForced(_args); } private set { } }

      public static bool IsForced(string[] args)
      {
         return
            args.Any(strArg =>
               arr_strOptions.Any(strOpt =>
                  strOpt.Equals(strArg, System.StringComparison.CurrentCultureIgnoreCase)));
      }
   }
}
