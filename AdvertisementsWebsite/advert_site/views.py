from django.shortcuts import render, HttpResponse
from .models import Advertisement
from .forms import AdvertForm

# Create your views here.


def getAdvert(request, advertId):

    advert = Advertisement.objects.get(id=advertId)
    return render(request, 'advert.html', {
        'advert': advert
    })      

def homepage(request):

    adverts = Advertisement.objects.all()

    return render(request, 'home.html', {
        'adverts': adverts,
    })

def newAdvert(request):

    form = AdvertForm()

    return render(request, 'add.html', {
        'form': form
    })