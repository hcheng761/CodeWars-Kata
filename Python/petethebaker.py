def cakes(recipe, available):
    # TODO: insert code
    match = []
    for name in set(recipe).intersection(available):
        match.append(available.get(name)/recipe.get(name))
    if len(match) != len(recipe):
        return 0
    return min(match)
