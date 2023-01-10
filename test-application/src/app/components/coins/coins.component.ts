import { Component, OnInit } from '@angular/core';
import { CoinsService } from 'src/app/services/coins.service';

@Component({
  selector: 'app-coins',
  templateUrl: './coins.component.html',
  styleUrls: ['./coins.component.scss']
})
export class CoinsComponent implements OnInit {
  coins: any;
  errorMessage:any;
  constructor(private coinsService: CoinsService) { }

  ngOnInit(): void {
    this.getFavoriteCities();
  }

  getFavoriteCities() {
    this.coinsService.getNegetiveTrendCoins()
      .subscribe((c: any) => {c.Message==null? this.coins = c.Data:this.errorMessage=c.Message; debugger;});
  }

}
