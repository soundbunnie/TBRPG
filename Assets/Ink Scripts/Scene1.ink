INCLUDE Scene2.ink
INCLUDE globals.ink


{ pokemon_name == "": -> main}
=== main ===
This first line is going to be really really long, probably. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.
Which pokemon do you choose?
    + [Charmander, who evolves into Charmeleon at level 16 and Charizard at 36. FILLER TEXTFILLER TEXTFILLER TEXTFILLER TEXTFILLER TEXTFILLER]
        ~ pokemon_name = "Charmander"
        -> chosen()
    + [Bulbasaur]
        ~ pokemon_name = "Bulbasaur"
        -> chosen()
    + [Squirtle]
        ~ pokemon_name = "Squirtle"
        -> chosen()
    + [Charmander, who evolves into Charmeleon at level 16 and Charizard at 36.]
        ~ pokemon_name = "Charmander"
        -> chosen()
    + [Bulbasaur]
        ~ pokemon_name = "Bulbasaur"
        -> chosen()
    + [Squirtle]
        ~ pokemon_name = "Squirtle"
        -> chosen()
        