/* via http://ru.wikipedia.org
 * @ 1/28/2009 3:18 PM CST */
using System;
namespace бизнес_сфере{
  public class машина{
    public static UInt64 вычисления_хэш(string вход){
      UInt64 мешанина=3074457345618258791ul;
      for(int i=0;i<вход.Length;++i){
        мешанина+=вход[i];
        мешанина*=3074457345618258791ul;
      }
      return мешанина;
    }
  }
}