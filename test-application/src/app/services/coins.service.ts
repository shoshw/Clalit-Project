import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CoinsService {
  Url = 'https://localhost:44333/api/Coins/GetCoins';
  constructor(private http: HttpClient) { }

  getNegetiveTrendCoins() {
    debugger;
    return this.http.get(this.Url)
  }
}
