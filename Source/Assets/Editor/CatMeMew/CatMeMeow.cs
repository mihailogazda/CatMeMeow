using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if DOES_IT_MEOW_IT_INDEED_DOES_MEOW
                      _
                      \`*-.
                       )  _`-.
                      .  : `. .
                      : _   '  \
                      ; *` _.   `*-._
                      `-.-'          `-.
                        ;       `       `.
                        :.       .        \
                        . \  .   :   .-'   .
                        '  `+.;  ;  '      :
                        :  '  |    ;       ;-.
                        ; '   : :`-:     _.`* ;
               [bug] .*' /  .*' ; .*`- +'  `*'
                     `*-*   `*-*  `*-*'

#endif

/// <summary>
/// Bad news for all you cat lovers:
/// That feline you are obsessed with is a total jerk. Sure, cats are cute, soft,
/// lovable and an endless source of viral GIFs and memes, but in actuality, they kinda suck.
/// Don't hate us for this blasphemy just yet. We understand your dilemma.
/// Some people just love cats, and to be honest, we can't really blame them for that.
/// Sure, cats are selfishly indifferent to your wellbeing, and in their minds you are their pets,
/// not the other way around, but...look at the kitty!
/// </summary>
public class CatsMakeItBetterMeow
{

    [MenuItem("Help/Show me a cat, meow!")]
    public static void PleaseHelpMeow()
    {
        Application.OpenURL("http://thecatapi.com/api/images/get?format=src&type=gif&size=full");
    }

}
