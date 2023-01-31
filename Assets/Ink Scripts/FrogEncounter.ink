INCLUDE ChooseClass.ink
-> choose_class
=== encounterFrog ===
You encounter a frog! #portraitText:Frog #portraitImg: frog_dude_neutral
{stat_check(Perception, "Easy")}
{passed:
[PERCEPTION: SUCCESS] Your keen senses allow you to observe a few things about the frog. #observations:He looks to be around 3.5 in tall. Seems to have a friendly disposition. #portraitText: Mr. Frog
} 
He seems like a very good boy.
{stat_check(Acrobatics, "Absurd")}
{passed:
[ACROBATICS: SUCCESS] You're able to do a cool trick for the frog. He is impressed. #portraitImg: frog_dude_happy
}
What do you do? #portraitImg: frog_dude_neutral
+ [Pet him]
    He's bursting with energy now! #portraitImg: frog_dude_happy
+ [Nothing]
    All right then.
- End of encounter.
-> DONE
