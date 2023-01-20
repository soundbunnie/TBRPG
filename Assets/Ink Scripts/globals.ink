VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

LIST Skills = Acrobatics, Stealth, Theft, Lockpicking, Forgery, Persuasion, Intimidation, Lying, Charm, Lifting, Running, Strength, Alchemy, Cultures, Reading, Writing, Trading, Knowledge

LIST Proficiencies = Swords, Spears, Shields, Daggers, Axes, Hammers, Unarmed, Instruments

/* 
PLAYER FUNCTIONS
*/

=== function add_skill(skill) ===
~ Skills += skill
Gained skill: {skill}

=== function remove_skill(skill) ===
~ Skills -= skill 
Lost skill: {skill}