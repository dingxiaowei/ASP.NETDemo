function KLineDataModelConvert() {
    let jsonData = [
        {
            date: '2021/1/2',
            openPrice: 2320.26,
            closePrice: 2320.26,
            lowestPrice: 2287.3,
            highestPrice: 2362.94,
            MA5: 2,
            MA10: 3,
            MA20: 4,
            MA30: 5,
            MA60: 6,
            MA120: 7,
        },
        {
            date: '2021/2/2',
            openPrice: 1320.26,
            closePrice: 2320.26,
            lowestPrice: 1287.3,
            highestPrice: 3362.94,
            MA5: 2,
            MA10: 3,
            MA20: 4,
            MA30: 5,
            MA60: 6,
            MA120: 7,
        },
    ]
    let outputData = []
    for (let item of jsonData) {
        let currentData = [
            item.date,
            item.openPrice,
            item.closePrice,
            item.lowestPrice,
            item.highestPrice,
            item.MA5,
            item.MA10,
            item.MA20,
            item.MA30,
            item.MA60,
            item.MA120,]
        outputData.push(currentData)
    }
    console.log(outputData)
}
