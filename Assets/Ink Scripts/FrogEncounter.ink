=== encounterFrog ===
You encounter a frog! #playMusic: menuToBattleMusic
He seems like a very good boy.
-> encounterFrogActions

=== encounterFrogActions ===
{set_default_stats()}
What do you do?
// to do: the non-sticky stat checks disappear from the choices menu after they've been chosen. this is a little bit visually unappealing, find a way to keep the option there but unselectable and differently colored

// idea: add a choice that has the same text as the non-sticky choices after selecting them and make them unselectable and colored via tags
    * [PERCEPTION: EASY I'd like to understand him more. I take a moment to see what I can discern. #statCheck: Perception]
        {stat_check_single(Perception, "Easy")}
        {passed:
            [PERCEPTION: SUCCESS] Your keen senses allow you to observe a few things about the frog: His height, title, the essence of his soul, and his name. #observations:* ~3.5 in tall.<br> * Seems to have a friendly disposition.<br> #portraitText: Mr. Frog #playSFX: stat_check_pass
        } 
        {not passed:
            [PERCEPTION: FAILED] You feel as if he's on a completely different world than you. #observations: * Possibly an alien.<br> #playSFX: stat_check_fail
        }
        -> encounterFrogActions
    * [DEXTERITY + INFLUENCE: HARD I want his friendship. I'll attempt to do a cool trick for him. #statCheck: DEX + INT] 
        {stat_check_double(Dexterity, Influence, "Hard")}
        {passed:
        [DEXTERITY + INFLUENCE: SUCCESS] You're able to do a cool trick for the frog. He is impressed#portraitImg: frog_dude_happy #observations: * Likes cool tricks<br> #playSFX: stat_check_pass
            }
        {not passed:
            [DEXTERITY + INFLUENCE: FAILED] Your attempt has backfired. The frog interprets your actions as an act of racism. #observations: * Thinks you're racist.<br> #playSFX: stat_check_fail
        }
        -> encounterFrogActions
    + [Pet him]
        He's bursting with energy now!#playSFX: yay #observations: * PETTED<br>
        -> encounterFrogActions
    + [(next) Nothing] 
        All right then.
End of encounter. #playSFX: encounterWin
-> DONE
