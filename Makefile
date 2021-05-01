.PHONE: clean
clean: dist-clean
	-(ls -F ./src | grep '/$$' | awk '{print "./src/" $$1 "bin"}' | xargs rm -r)
	-(ls -F ./src | grep '/$$' | awk '{print "./src/" $$1 "obj"}' | xargs rm -r)

PHONY: dist-clean
dist-clean:
	-rm -r ./dist/*

.PHONE: dist
dist: dist-clean
	mkdir -p ./dist/WebView2_AddToCart
	cp -r ./src/* ./dist/WebView2_AddToCart
	(cd ./dist; zip -r ./WebView2_AddToCart.zip ./WebView2_AddToCart)
