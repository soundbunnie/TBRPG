INCLUDE ChooseClass.ink
-> choose_class
=== encounterFrog ===
You encounter a frog! #portraitText:Frog #portraitImg: frog_dude_neutral
{stat_check(Perception, "Easy")}
{passed: [PERCEPTION: SUCCESS] Your keen senses observe a few things about the frog.} #observations:He looks to be around 3.5 in tall. Seems to have a friendly disposition.
He seems like a very good boy.
What do you do?
+ [Pet him]
    He's bursting with energy now! #portraitImg: frog_dude_happy
+ [Nothing]
    All right then.
- End of encounter.
-> DONE
