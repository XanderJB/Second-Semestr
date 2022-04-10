import os
import requests

#получить API-ключ - https://app.pdf.co/login
API_KEY = input("Enter key: ")

BASE_URL = "https://api.pdf.co/v1"

SourceFile = ".\\table_1.pdf"
Pages = ""
Password = ""
DestinationFile = ".\\result_1.json"


def main(args = None):
    uploadedFileUrl = uploadFile(SourceFile)
    if (uploadedFileUrl != None):
        convertPdfToJson(uploadedFileUrl, DestinationFile)


def convertPdfToJson(uploadedFileUrl, destinationFile):
    """Converts PDF To Json using PDF.co Web API"""

    parameters = {}
    parameters["name"] = os.path.basename(destinationFile)
    parameters["password"] = Password
    parameters["pages"] = Pages
    parameters["url"] = uploadedFileUrl

    url = "{}/pdf/convert/to/json".format(BASE_URL)

    response = requests.post(url, data=parameters, headers={ "x-api-key": API_KEY })
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:
            resultFileUrl = json["url"]
            r = requests.get(resultFileUrl, stream=True)
            if (r.status_code == 200):
                with open(destinationFile, 'wb') as file:
                    for chunk in r:
                        file.write(chunk)
                print(f"Result file saved as \"{destinationFile}\" file.")
            else:
                print(f"Request error: {response.status_code} {response.reason}")
        else:
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")


def uploadFile(fileName):
    url = "{}/file/upload/get-presigned-url?contenttype=application/octet-stream&name={}".format(
        BASE_URL, os.path.basename(fileName))
    response = requests.get(url, headers={ "x-api-key": API_KEY })
    if (response.status_code == 200):
        json = response.json()
        if json["error"] == False:
            uploadUrl = json["presignedUrl"]
            uploadedFileUrl = json["url"]
            with open(fileName, 'rb') as file:
                requests.put(uploadUrl, data=file, headers={ "x-api-key": API_KEY, "content-type": "application/octet-stream" })
            return uploadedFileUrl
        else:
            print(json["message"])    
    else:
        print(f"Request error: {response.status_code} {response.reason}")
    return None

if __name__ == '__main__':
    main()