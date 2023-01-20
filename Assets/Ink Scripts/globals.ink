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

LIST Goals = Fight, Merchant, Enlightenment

/* 
PLAYER STATS
MIN 1 MAX 5
*/

// Physical stats
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
~ Skills += skill
Gained skill: {skill}

=== function remove_skill(skill) ===
~ Skills -= skill 
Lost skill: {skill}

=== function add_proficiency(proficiency) ===
~ Proficiencies += proficiency
New proficiency: {proficiency}

=== function remove_proficiency(proficiency) ===
~ Proficiencies -= proficiency
Lost proficiency: {proficiency}

=== function add_trait(trait) ===
~ Traits += trait
New trait: {trait}

=== function remove_trait(trait) ===
~ Traits -= trait
Lost trait: {trait}
