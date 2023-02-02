INCLUDE ChooseClass.ink
-> choose_class
=== encounterFrog ===
You encounter a frog! #portraitText:Frog #portraitImg: frog_dude_neutral  #playMusic: battleMusic
He seems like a very good boy.
-> encounterFrogActions

=== encounterFrogActions ===
What do you do? #portraitImg: frog_dude_neutral
    * [\[PERCEPTION\] I'd like to understand him more. I take a moment to see what I can discern.]
        {stat_check(Perception, "Easy")}
        {passed:
            [PERCEPTION: SUCCESS] Your keen senses allow you to observe a few things about the frog: His height, title, the essence of his soul, and his name. #observations:* ~3.5 in tall. * Seems to have a friendly disposition. #portraitText: Mr. Frog
        } 
        {not passed:
            [PERCEPTION: FAILED] You feel as if he's on a completely different world than you. #observations: * Possibly an alien. 
        }
        -> encounterFrogActions
    * [\[ACROBATICS\] I want his friendship. I'll attempt to do a cool trick for him.]
        {stat_check(Acrobatics, "Hard")}
        {passed:
        [ACROBATICS: SUCCESS] You're able to do a cool trick for the frog. He is impressed. #portraitImg: frog_dude_happy #observations: * Likes cool tricks
            }
        {not passed:
            [ACROBATICS: FAILED] Your attempt has backfired. The frog interprets your actions as an act of racism. #observations: * Thinks you're racist.
        }
        -> encounterFrogActions
    + [Pet him]
        He's bursting with energy now! #portraitImg: frog_dude_happy
        -> encounterFrogActions
    + [Nothing]
        All right then.
End of encounter.
-> END
