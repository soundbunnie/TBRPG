// Skills, stats and proficiencies
INCLUDE Globals\stats.ink
INCLUDE Globals\skills.ink
INCLUDE Globals\proficiencies.ink
VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

VAR player_name = ""

VAR player_title = ""

LIST Traits = Moral, Immoral, Cunning, Honourable, Kleptomaniac, Survivor, Outcast, Noble, Merchant, Irritable, Cheery, Gloomy, Generous, Revered, Chaotic

LIST Goals = Battle, Merchant, Knowledge, Chaos, Betterment, Kleptomania, Contentment

/*
PLAYER FUNCTIONS
*/

=== function add_trait(trait) ===
~ Traits += trait

=== function remove_trait(trait) ===
~ Traits -= trait
