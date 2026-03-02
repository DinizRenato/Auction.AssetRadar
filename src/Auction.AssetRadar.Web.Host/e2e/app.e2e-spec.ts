import { AssetRadarTemplatePage } from './app.po';

describe('AssetRadar App', function () {
    let page: AssetRadarTemplatePage;

    beforeEach(() => {
        page = new AssetRadarTemplatePage();
    });

    it('should display message saying app works', () => {
        page.navigateTo();
        expect(page.getParagraphText()).toEqual('app works!');
    });
});
