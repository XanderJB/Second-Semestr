def print_valid_cities(all_cities, used_cities):
    all_cities = {
    'Абакан',
    'Астрахань',
    'Бобруйск',
    'Калуга',
    'Караганда',
    'Кострома',
    'Липецк',
    'Новосибирск'
}

    used_cities = {'Калуга', 'Абакан', 'Новосибирск'}

    cities = all_cities.difference(used_cities)
    for city in cities:
        city = cities
        print(city)
print_valid_cities()

    # Вместо этого многоточия напишите код функции, она должна
    # принимать и обрабатывать аргументы all_cities и used_cities,
    # а затем печатать результат в нужном формате
