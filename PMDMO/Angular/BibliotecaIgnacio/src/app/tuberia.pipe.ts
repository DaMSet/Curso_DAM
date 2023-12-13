import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tuberia'
})
export class TuberiaPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    return null;
  }

}
