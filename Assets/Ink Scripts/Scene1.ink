INCLUDE Scene2.ink

VAR pokemon_name = ""

{ pokemon_name == "": -> main | -> already_chose }
=== main ===
Which pokemon do you choose?
    + [Charmander]
        -> chosen("Charmander")
    + [Bulbasaur]
        -> chosen("Bulbasaur")
    + [Squirtle]
        ~ pokemon_name = "Squirtle"
        -> chosenAgain()
        
=== chosen(pokemon) ===
~ pokemon_name = pokemon
You chose {pokemon}!
-> END

=== already_chose ===
You already chose {pokemon_name}!
-> END