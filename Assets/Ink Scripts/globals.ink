VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

VAR player_title = ""

LIST Skills = Acrobatics, Stealth, Theft, Lockpicking, Forgery, Persuasion, Intimidation, Lying, Charm, Lifting, Running, Strength, Alchemy, Cultures, Reading, Writing, Trading, Knowledge, Force, Negotiation

LIST Proficiencies = Swords, Spears, Shields, Daggers, Axes, Hammers, Unarmed, Instruments, Gambling

LIST Traits = Moral, Immoral, Cunning, Honourable, Kleptomaniac, Survivor, Outcast, Noble, Merchant, Irritable, Cheery, Gloomy, Generous, Revered, Chaotic

LIST Goals = Fight, Merchant, Enlightenment

/* 
PLAYER STATS
*/

VAR Perception = 0
VAR Hiding = 0
VAR Empathy = 0
VAR History = 0
VAR Logic = 0
VAR Willpower = 0
VAR Introspection = 0


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