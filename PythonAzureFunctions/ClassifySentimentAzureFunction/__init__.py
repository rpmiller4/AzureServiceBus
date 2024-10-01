import logging

import azure.functions as func
import json
from textblob import TextBlob

def classify_sentiment(text):
    analysis = TextBlob(text)
    if analysis.sentiment.polarity > 0:
        return "Positive"
    elif analysis.sentiment.polarity < 0:
        return "Negative"
    else:
        return "Neutral"
    
def main(req: func.HttpRequest) -> func.HttpResponse:
    text = req.params.get('text')
    if not text:
        return func.HttpResponse(
            "Please provide a 'text' parameter in the query string.",
            status_code=400
        )
    classification = classify_sentiment(text)
    result = {
        'text': text,
        'classification': classification
    }
    return func.HttpResponse(json.dumps(result), mimetype="application/json")


