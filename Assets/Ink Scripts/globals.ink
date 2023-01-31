VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

VAR player_name = ""

VAR player_title = ""

LIST Skills = Acrobatics, Theft, Lockpicking, Forgery, Lying, Charm, Lifting, Running, Alchemy, Cultures, Reading, Writing, Trading, Force, Negotiation

LIST Proficiencies = Swords, Spears, Shields, Daggers, Axes, Hammers, Unarmed, Instruments, Gambling

LIST Traits = Moral, Immoral, Cunning, Honourable, Kleptomaniac, Survivor, Outcast, Noble, Merchant, Irritable, Cheery, Gloomy, Generous, Revered, Chaotic

LIST Goals = Battle, Merchant, Knowledge, Chaos, Betterment, Kleptomania, Contentment

/* 
PLAYER STATS
1: Basic competency
2: Decent
3: Good
4: Very good
5: Amazing
*/

// Physical stats
VAR Health = (20)
VAR Strength = (1)
VAR Stealth = (1)

// Mental stats
VAR Influence = (1)
VAR Empathy = (1)
VAR Logic = (1)
VAR Willpower = (1)
VAR Introspection = (1)

// Passive stats
VAR Perception = (1)
VAR History = (1)


/* 
PLAYER FUNCTIONS
*/

=== function add_skill(skill) ===
{ skill >= 10:
Skills += skill
}


=== function remove_skill(skill) ===
~ Skills -= skill 

=== function add_proficiency(proficiency) ===
{ proficiency >= 10:
Proficiencies += proficiency
}

=== function remove_proficiency(proficiency) ===
~ Proficiencies -= proficiency

=== function add_trait(trait) ===
{ trait >= 10:
Traits += trait
}

=== function remove_trait(trait) ===
~ Traits -= trait
