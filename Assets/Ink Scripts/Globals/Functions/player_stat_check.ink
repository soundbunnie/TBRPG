VAR to_pass = ()
VAR passed = ()

=== function stat_check_single(stat, difficulty) === // might need to seperate this into different files once enemy AI is introduced
~ passed = false // Set passed to false every time this function is called
// Formula for calculating dice roll
~ temp dice_roll = stat // note: this will have to be changed as the system becomes 
{difficulty: // note: could the roll difficulty parameters be set somewhere else?
- "Easy": ~ to_pass = 2
- "Medium": ~ to_pass = 4
- "Hard": ~ to_pass = 6
- "Absurd": ~ to_pass = 8
}
{dice_roll >= to_pass:
~ passed = true
}
{dice_roll}

=== function stat_check_double(stat1, stat2, difficulty) === // might need to seperate this into different files once enemy AI is introduced
~ passed = false // Set passed to false every time this function is called
// Formula for calculating dice roll
~ temp roll1 = stat1 
~ temp roll2 = stat2
~ temp dice_roll = roll1 + roll2
{difficulty: // note: could the roll difficulty parameters be set somewhere else?
- "Easy": ~ to_pass = 4
- "Medium": ~ to_pass = 6
- "Hard": ~ to_pass = 12
- "Absurd": ~ to_pass = 18
}
{dice_roll >= to_pass:
~ passed = true
}
{roll1} {roll2}