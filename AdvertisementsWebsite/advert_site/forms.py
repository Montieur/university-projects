from django.forms import ModelForm
from .models import Advertisement

class AdvertForm(ModelForm):
    class Meta:
        model = Advertisement
        fields = [
            'brandName',
            'modelName',
            'yearOfProduction',
            'mileage',
            'description',
            'price',
            'phone',
            'mail'
        ]
        labels = {
            'brandName': 'Marka',
            'modelName': 'Model',
            'yearOfProduction': 'Rok produkcji',
            'mileage': 'Przebieg',
            'description': 'Opis',
            'price': 'Cena',
            'phone': 'Telefon',
            'mail': 'Adres e-mail'
        }
        