def get_together_games(games_1, games_2):
    # Напишите здесь код функции для поиска пересечений
    together_games = set(games_1).intersection(set(games_2))
    return together_games
anfisa_games = [
    'Online-chess',
    'Города',
    'DOOM',
    'Крестики-нолики'
]
alisa_games = [
    'DOOM',
    'Online-chess',
    'Города',
    'GTA',
    'World of tanks'
]
# Вызовите функцию со списками игр в качестве параметров
together_games = set(alisa_games).intersection(set(anfisa_games))
# Напечатайте итоговый перечень игр в цикле
for games in together_games:
    print("👾", games)

get_together_games(alisa_games, anfisa_games)