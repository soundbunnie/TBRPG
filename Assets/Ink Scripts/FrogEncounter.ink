INCLUDE Globals\globals.ink
INCLUDE ChooseClass.ink
You encounter a frog! #portraitText:Frog #portraitImg: frog_dude_neutral  #observations:He looks to be around 3.5 in tall. Seems to have a friendly disposition.
-> encounterFrog

=== encounterFrog ===
He seems like a very good boy.
What do you do?
+ [Pet him]
    He's bursting with energy now! #portraitImg: frog_dude_happy
+ [Nothing]
    All right then.
- End of encounter.
-> choose_class
