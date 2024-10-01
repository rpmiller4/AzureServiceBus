# AzureServiceBus
Azure Service Bus exercise

# What does it do?

- It uses a C# Azure ServiceBus trigger that categorizes a plain text file by size into small, medium, or large.
- It uses a Python Azure Http Trigger that does sentiment analysis on json document. Classifies it as Negative, Neutral, or Positive.
  - The second function is currently available at https://excercisepython.azurewebsites.net/api/ClassifySentimentAzureFunction?text=%22I%20am%20feeling%20a%20little%20happy%22


## Contains

- Single Azure ServiceBus method in standard C#
- Attempt at python language Azure Function for classification tasks.

used `npm install -g azure-functions-core-tools@3 --unsafe-perm true` in PythonAzureFunctions (although v4 may be available). Had to clear cache and reinstall node 22.9.0, although likely only one or the other was needed.

## How to install python and run the python Azure function

```
C:\git\AzureServiceBus>cd C:\git\AzureServiceBus\PythonAzureFunctions

C:\git\AzureServiceBus\PythonAzureFunctions>py -3.7 -m venv env

C:\git\AzureServiceBus\PythonAzureFunctions>env\Scripts\activate

(env) C:\git\AzureServiceBus\PythonAzureFunctions>python -m pip install --upgrade pip
Collecting pip
  Using cached pip-24.0-py3-none-any.whl (2.1 MB)
Installing collected packages: pip
  Attempting uninstall: pip
    Found existing installation: pip 20.1.1
    Uninstalling pip-20.1.1:
      Successfully uninstalled pip-20.1.1
Successfully installed pip-24.0

(env) C:\git\AzureServiceBus\PythonAzureFunctions>pip --version
pip 24.0 from c:\git\azureservicebus\pythonazurefunctions\env\lib\site-packages\pip (python 3.7)

(env) C:\git\AzureServiceBus\PythonAzureFunctions>pip install -r requirements.txt
Collecting azure-functions (from -r requirements.txt (line 3))
  Using cached azure_functions-1.21.1-py3-none-any.whl.metadata (6.8 kB)
Collecting textblob (from -r requirements.txt (line 4))
  Using cached textblob-0.17.1-py2.py3-none-any.whl.metadata (4.2 kB)
Collecting nltk>=3.1 (from textblob->-r requirements.txt (line 4))
  Using cached nltk-3.8.1-py3-none-any.whl.metadata (2.8 kB)
Collecting click (from nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached click-8.1.7-py3-none-any.whl.metadata (3.0 kB)
Collecting joblib (from nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached joblib-1.3.2-py3-none-any.whl.metadata (5.4 kB)
Collecting regex>=2021.8.3 (from nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached regex-2024.4.16-cp37-cp37m-win_amd64.whl.metadata (41 kB)
Collecting tqdm (from nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached tqdm-4.66.5-py3-none-any.whl.metadata (57 kB)
Collecting colorama (from click->nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached colorama-0.4.6-py2.py3-none-any.whl.metadata (17 kB)
Collecting importlib-metadata (from click->nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached importlib_metadata-6.7.0-py3-none-any.whl.metadata (4.9 kB)
Collecting zipp>=0.5 (from importlib-metadata->click->nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached zipp-3.15.0-py3-none-any.whl.metadata (3.7 kB)
Collecting typing-extensions>=3.6.4 (from importlib-metadata->click->nltk>=3.1->textblob->-r requirements.txt (line 4))
  Using cached typing_extensions-4.7.1-py3-none-any.whl.metadata (3.1 kB)
Using cached azure_functions-1.21.1-py3-none-any.whl (185 kB)
Using cached textblob-0.17.1-py2.py3-none-any.whl (636 kB)
Using cached nltk-3.8.1-py3-none-any.whl (1.5 MB)
Using cached regex-2024.4.16-cp37-cp37m-win_amd64.whl (269 kB)
Using cached click-8.1.7-py3-none-any.whl (97 kB)
Using cached joblib-1.3.2-py3-none-any.whl (302 kB)
Using cached tqdm-4.66.5-py3-none-any.whl (78 kB)
Using cached colorama-0.4.6-py2.py3-none-any.whl (25 kB)
Using cached importlib_metadata-6.7.0-py3-none-any.whl (22 kB)
Using cached typing_extensions-4.7.1-py3-none-any.whl (33 kB)
Using cached zipp-3.15.0-py3-none-any.whl (6.8 kB)
Installing collected packages: azure-functions, zipp, typing-extensions, regex, joblib, colorama, tqdm, importlib-metadata, click, nltk, textblob
Successfully installed azure-functions-1.21.1 click-8.1.7 colorama-0.4.6 importlib-metadata-6.7.0 joblib-1.3.2 nltk-3.8.1 regex-2024.4.16 textblob-0.17.1 tqdm-4.66.5 typing-extensions-4.7.1 zipp-3.15.0

(env) C:\git\AzureServiceBus\PythonAzureFunctions>python --version
Python 3.7.8

(env) C:\git\AzureServiceBus\PythonAzureFunctions>func start
Found Python version 3.7.8 (py).

Azure Functions Core Tools
Core Tools Version:       3.0.5682 Commit hash: N/A  (64-bit)
Function Runtime Version: 3.22.0.0


Functions:

        MyPythonFunction: [GET,POST] http://localhost:7071/api/MyPythonFunction

For detailed output, run func with --verbose flag.
[2024-10-01T06:16:34.867Z] Worker process started and initialized.
[2024-10-01T06:17:03.664Z] Executing 'Functions.MyPythonFunction' (Reason='This function was programmatically called via the host APIs.', Id=2622f881-4d85-4370-a79c-c138890c665c)
[2024-10-01T06:17:03.725Z] Executed 'Functions.MyPythonFunction' (Succeeded, Id=2622f881-4d85-4370-a79c-c138890c665c, Duration=81ms)
```
