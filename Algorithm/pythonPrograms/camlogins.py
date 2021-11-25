import aiohttp
import asyncio
from asyncio.windows_events import NULL
from typing import List

import sys
import time
from collections import Counter
import json
import socket



asyncio.set_event_loop_policy(asyncio.WindowsSelectorEventLoopPolicy())

urls=['https://www.google.com','https://www.yahoo.com']
def GetDNSAnswers():
    getAnswer=socket.gethostbyname_ex("google.com")



async def get(url,session):
    try:
        async with session.get(url=url,) as response:
            resp =await response.read()
            jsonResponse = await response.json(content_type=None)
            
    except Exception as e:
        print("failed,unable to get url{} dur to {}".format(url,e.__class__))

async def main(urls,component):
    async with aiohttp.ClientSession() as session:
        ret = await asyncio.gather(*[get(url,session) for url in urls])
    print("completed all,return is a list of {} outputs".format(len(ret)))


asyncio.run(main(urls,""))