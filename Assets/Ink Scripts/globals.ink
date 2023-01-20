VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

LIST Skills = Acrobatics, Stealth, Theft, Lockpicking, Persuasion, Intimidation, Lying, Charm, Lifting, Running, Strength, Alchemy, Cultures, Reading, Writing, Trading, Knowledge

/* 
PLAYER FUNCTIONS
*/

=== function add_skill(skill) ===
~ Skills += skill
Gained skill: {skill}
