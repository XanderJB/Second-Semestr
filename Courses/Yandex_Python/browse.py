import requests

url = 'http://wttr.in/?0'

response = requests.get(url)  # выполните HTTP-запрос

print(response.text)  # напечатайте текст HTTP-ответа