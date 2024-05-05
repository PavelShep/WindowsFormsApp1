### Opis projektu

Ten projekt to prosta aplikacja na platformę Windows Forms, która umożliwia użytkownikowi przeglądanie informacji o różnych krajach świata. Użytkownik może wybierać region i podregion, aby wyświetlić odpowiadające im kraje, a także uzyskiwać informacje o wybranym kraju, takie jak nazwa, stolica, flaga, herb, populacja i inne dane.

### Instalacja i uruchomienie

1. Sklonuj repozytorium na swój komputer za pomocą polecenia:
```
git clone https://github.com/PavelShep/WindowsFormsApp1.git
```
2. Otwórz projekt w programie Visual Studio.
3. Skompiluj i uruchom projekt.

### Użycie

1. Po uruchomieniu aplikacji kliknij przycisk "Czytaj API", aby załadować informacje o krajach.
2. Wybierz region i podregion z odpowiednich list.
3. Kliknij przycisk "Wczytaj kraje z regiona", aby wyświetlić listę krajów wybranego regionu i podregionu.
4. Wybierz interesujący cię kraj z listy.
5. Kliknij przycisk "Wczytaj dane", aby uzyskać dodatkowe informacje o wybranym kraju, takie jak stolica, flaga, herb itp.

### Używane API

1. **restcountries.com API**: Do uzyskiwania informacji o krajach świata.
2. **timeapi.io API**: Do uzyskiwania bieżącej daty i czasu w stolicy wybranego kraju.
3. **open-meteo.com API**: Do uzyskiwania bieżącej temperatury w stolicy wybranego kraju.
4. **nbp.pl API**: Do uzyskiwania kursów walut.

### Zależności

- Newtonsoft.Json - używane do pracy z danymi JSON.
