INCLUDE ChooseClass.ink
// Divert to choose class so the player starts there
-> choose_class // note: this script needs access to global variables and including globals.ink more than once creates everything contained in it twice. for now, every ink script will include chooseclass
=== encounterFrog ===
You encounter a frog! #portraitText:Frog #portraitImg: frog_dude_neutral  #playMusic: menuToBattleMusic
He seems like a very good boy.
-> encounterFrogActions

=== encounterFrogActions ===
What do you do? #portraitImg: frog_dude_neutral
// to do: the non-sticky stat checks disappear from the choices menu after they've been chosen. this is a little bit visually unappealing, find a way to keep the option there but unselectable and differently colored
    * [\[PERCEPTION\] I'd like to understand him more. I take a moment to see what I can discern.]
        {stat_check(Perception, "Easy")}
        {passed:
            [PERCEPTION: SUCCESS] Your keen senses allow you to observe a few things about the frog: His height, title, the essence of his soul, and his name. #observations:* ~3.5 in tall. * Seems to have a friendly disposition. #portraitText: Mr. Frog #playSFX: stat_check_pass
        } 
        {not passed:
            [PERCEPTION: FAILED] You feel as if he's on a completely different world than you. #observations: * Possibly an alien. #playSFX: stat_check_fail
        }
        -> encounterFrogActions
    * [\[ACROBATICS\] I want his friendship. I'll attempt to do a cool trick for him.]
        {stat_check(Acrobatics, "Hard")}
        {passed:
        [ACROBATICS: SUCCESS] You're able to do a cool trick for the frog. He is impressed. #portraitImg: frog_dude_happy #observations: * Likes cool tricks #playSFX: stat_check_pass
            }
        {not passed:
            [ACROBATICS: FAILED] Your attempt has backfired. The frog interprets your actions as an act of racism. #observations: * Thinks you're racist. #playSFX: stat_check_fail
        }
        -> encounterFrogActions
    + [Pet him]
        He's bursting with energy now! #portraitImg: frog_dude_happy #playSFX: yay
        -> encounterFrogActions
    + [Nothing]
        All right then.
End of encounter.
-> END
