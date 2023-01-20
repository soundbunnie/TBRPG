VAR pokemon_name = ""

/*
PLAYER VARIABLES
*/

VAR player_class = ""

LIST Skills = acrobatics, stealth, theft, lockpicking, persuasion, intimidation, lying, charm, lifting, running, strength, alchemy, cultures, reading, writing, trading, knowledge

/* 
PLAYER FUNCTIONS
*/

=== function add_skill(skill) ===
~ Skills += skill
