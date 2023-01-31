INCLUDE Globals\stats.ink
INCLUDE Globals\skills.ink
VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

VAR player_name = ""

VAR player_title = ""

LIST Proficiencies = Swords, Spears, Shields, Daggers, Axes, Hammers, Unarmed, Instruments, Gambling

LIST Traits = Moral, Immoral, Cunning, Honourable, Kleptomaniac, Survivor, Outcast, Noble, Merchant, Irritable, Cheery, Gloomy, Generous, Revered, Chaotic

LIST Goals = Battle, Merchant, Knowledge, Chaos, Betterment, Kleptomania, Contentment

/*
PLAYER FUNCTIONS
*/

=== function add_proficiency(proficiency) ===
~ Proficiencies += proficiency

=== function remove_proficiency(proficiency) ===
~ Proficiencies -= proficiency

=== function add_trait(trait) ===
~ Traits += trait

=== function remove_trait(trait) ===
~ Traits -= trait
